﻿using muscshop.Context;
using muscshop.filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace muscshop.Controllers
{
    [SessionFilter]
    public class StoreController : Controller
    {
        

        StoreContext _storeContext = new StoreContext();


   
        public ActionResult Index()
        {
            var genres = _storeContext.Genres;
            // var genres = _database.Genres;
            return View(genres);
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = _storeContext.Genres.Include("Albums").Where(x => x.Name == genre).FirstOrDefault();

            return View(genreModel);
        }

        public ActionResult Detail(int id)
        {
            var album = _storeContext.Albums.Include("Artist").Include("Genre").Where(x => x.AlbumId == id).FirstOrDefault();


            return View(album);
        }
    }
}