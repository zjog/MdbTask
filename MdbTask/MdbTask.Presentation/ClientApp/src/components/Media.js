import React from 'react'
import ReactStars from "react-rating-stars-component";
import { v4 as uuidv4 } from 'uuid';

export default function Media(props) {

    const saveRating = (rating) => {
        (async () => {
            await fetch('rating', {
                method: 'POST',
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify({ mediaId: props.mediaData.mediaId, userRating: rating })
            });
        })();
    };

    return (
        <div key={uuidv4()} className="row movie-row">
            <div className="col-3 px-2">
                <img className="img-fluid" src={'/media/' + props.mediaData.image} alt={props.mediaData.title} />
            </div>
            <div className="col-9 pe-5">
                <h5>{props.mediaData.title} <span>({props.mediaData.releaseYear})</span></h5>
                <p>{props.mediaData.descritpion}</p>
                <span>
                    <label>Cast:</label>
                    <ul>
                        {props.mediaData.cast.map(c =>
                            <li key={uuidv4()}>{c.name}</li>
                        )}
                    </ul>
                </span>
                <label>Rate this:</label>
                <ReactStars count={5} onChange={saveRating} size={24} activeColor="#ffd700" />
            </div>
        </div>
    )
}