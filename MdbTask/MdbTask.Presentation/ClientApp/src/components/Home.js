import React, { Component } from 'react';
import SearchField from 'react-search-field';
import BootstrapSwitchButton from 'bootstrap-switch-button-react'
import ReactStars from "react-rating-stars-component";
import { v4 as uuidv4 } from 'uuid';
import './components.css';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = {
            media: [],
            toShow: 10,
            isMovie: true,
            searchTerm: "",
            pageTitle: "Top Movies",
            loading: true
        };
        this.viewMore = this.viewMore.bind(this);
        this.updateSearch = this.updateSearch.bind(this);
        this.updateMediaType = this.updateMediaType.bind(this);
    }

    componentDidMount() {
        this.getMedia(false);
    }

    renderMediaList() {
        return (
            <div className="container">
                {this.state.media.map(m =>
                    <div key={uuidv4()} className="row movie-row">
                        <div className="col-3 px-2">
                            <img className="img-fluid" src={'/media/' + m.image} alt={m.title} />
                        </div>
                        <div className="col-9 pe-5">
                            <h5>{m.title} <span>({m.releaseYear})</span></h5>
                            <p>{m.descritpion}</p>
                            <span>
                                <label>Cast:</label>
                                <ul>
                                    {m.cast.map(c =>
                                        <li key={uuidv4()} >{c.name}</li>
                                    )}
                                </ul>
                            </span>
                            <ReactStars count={5} size={24} value={m.averageRating} activeColor="#ffd700" edit={false} isHalf={true} />
                            <label className="small">Average rating: {m.averageRating}</label>
                        </div>
                    </div>
                    )}
            </div>
        );
    }

    render() {
        let mediaList = this.state.loading
            ? <p className="text-center  py-5"><em>Loading...</em></p>
            : this.renderMediaList();

        const { search } = this.state.searchTerm;

        return (
            <div>
                <div className="container-md pt-5 pb-5">
                    <div className="row">
                        <div className="col-md-6 offset-md-3">
                            <SearchField placeholder="Search here ..." onChange={this.updateSearch} value={search} />
                        </div>
                    </div>
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
            searchTerm: this.state.searchTerm,
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
                media: append === true ? [...this.state.media, ...data] : data,
                loading: false
            })
        }
    }

    viewMore() {
        this.setState({
            toShow: this.state.toShow + 10,
        }, () => { this.getMedia(true); });
    }

    updateSearch(search) {
        if (search.trim() !== this.state.searchTerm.trim()
            && (search.length === 0 || search.trim().length > 1)) {
            this.setState({ searchTerm: search, toShow: 10, loading: true }, () => { this.getMedia(false); });
        }
    };

    updateMediaType() {
        this.setState({
            isMovie: !this.state.isMovie,
            toShow: 10,
            pageTitle: !this.state.isMovie ? "Top Movies" : "Top Shows",
        }, () => { this.getMedia(false); });
    }
}


