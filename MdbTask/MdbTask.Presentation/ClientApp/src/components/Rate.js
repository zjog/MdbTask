import React, { Component } from 'react';
import BootstrapSwitchButton from 'bootstrap-switch-button-react'
import { v4 as uuidv4 } from 'uuid';
import Media from './Media';
import './components.css';

export class Rate extends Component {
    static displayName = Rate.name;

    constructor(props) {
        super(props);
        this.state = {
            media: [],
            toShow: 10,
            isMovie: true,
            pageTitle: "Rate Movies",
            loading: true
        };
        this.updateMediaType = this.updateMediaType.bind(this);
        this.viewMore = this.viewMore.bind(this);
    }

    componentDidMount() {
        this.getMedia(false);
    }

    renderMediaList() {
        return (
            <div className="container">
                {this.state.media.map(m =>
                    <Media key={uuidv4()} mediaData={m} />
                )}
            </div>
        );
    }

    render() {
        let mediaList = this.state.loading
            ? <p className="text-center py-5"><em>Loading...</em></p>
            : this.renderMediaList();

        return (
            <div>
                <div className="container-md pt-5 pb-5">
                    <div className="row mt-2">
                        <div className="col text-center">
                            <BootstrapSwitchButton checked={this.state.isMovie} onlabel="Movies" offlabel="Shows" width={150} height={35} offstyle="primary" onChange={this.updateMediaType} />
                        </div>
                    </div>
                    <div className="row mt-2">
                        <h1 className="page-title text-center">{this.state.pageTitle}</h1>
                    </div>
                    <div className="row">
                        {mediaList}
                    </div>
                    <div className="row">
                        <div className="col-6 offset-3 text-center">
                            <button className="btn btn-primary" onClick={this.viewMore}>View more results</button>
                        </div>
                    </div>
                </div>
            </div>
        );
    }

    async getMedia(append) {
        const response = await fetch('media?' + new URLSearchParams({
            searchTerm: "",
            type: this.state.isMovie ? 1 : 0,
            limit: this.state.toShow
        }).toString())
        const status = response.status;
        if (status !== 200) {
            this.setState({
                loading: false
            });
        }
        else {
            const data = await response.json();
            this.setState({
                media: append ? [...this.state.media, ...data] : data,
                loading: false
            })
        }
    }

    viewMore() {
        this.setState({
            toShow: this.state.toShow + 10,
        }, () => { this.getMedia(true); });
    }

    updateMediaType() {
        this.setState({
            isMovie: !this.state.isMovie,
            pageTitle: !this.state.isMovie ? "Rate Movies" : "Rate Shows",
        }, () => { this.getMedia(false); });
    }
}
