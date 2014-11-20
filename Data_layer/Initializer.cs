
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.IO;
using Models;

namespace Data_layer
{
    public class Initializer : DropCreateDatabaseIfModelChanges<RadioContext>
    {
        protected override void Seed(RadioContext context)
        {

            #region Setting songs

            RateRules oneRate = new RateRules
            {
                PeopleListenedToAnd = 0,
                RatingGivedByListener = 0,
                PeopleListenedHalfWay = 0
            };
            RateRules twoRate = new RateRules
            {
                PeopleListenedToAnd = 0,
                RatingGivedByListener = 0,
                PeopleListenedHalfWay = 0
            };
            RateRules threeRate = new RateRules
            {
                PeopleListenedToAnd = 0,
                RatingGivedByListener = 0,
                PeopleListenedHalfWay = 0
            };
            RateRules fourRate = new RateRules
            {
                PeopleListenedToAnd = 0,
                RatingGivedByListener = 0,
                PeopleListenedHalfWay = 0
            };
            context.RateRuleses.Add(oneRate);
            context.RateRuleses.Add(twoRate);
            context.RateRuleses.Add(threeRate);
            context.RateRuleses.Add(fourRate);

            Song one = new Song
                {
                    Notes = "Some notes",
                    Title = "My song",
                    SongPath = "/Content/1.mp3",
                    RateRules = oneRate
                };
            Song two = new Song
                {
                    Notes = "Some notes!!",
                    Title = "My second song",
                    SongPath = "/Content/2.mp3",
                    RateRules = twoRate
                };
            Song three = new Song
                {
                    Notes = "Some notes!!",
                    Title = "My second song",
                    SongPath = "/Content/01.mp3",
                    RateRules = threeRate
                };
            Song four = new Song
                {
                    Notes = "Some notes!!",
                    Title = "My second song",
                    SongPath = "/Content/02.mp3",
                    RateRules = fourRate
                };
            context.Songs.Add(one);
            context.Songs.Add(two);
            context.Songs.Add(three);
            context.Songs.Add(four);


            #endregion

            #region Setting countries

            Region Poltava = new Region() {RegionName = "Poltava"};
            Region Cherkassy = new Region() {RegionName = "Cherkassy"};
            Region California = new Region() {RegionName = "California"};
            context.Regions.Add(Poltava);
            context.Regions.Add(Cherkassy);
            context.Regions.Add(California);

            Country Ukraine = new Country()
                {
                    CountryName = "Ukraine",
                    Regions = new List<Region> {Poltava, Cherkassy},
                };
            Country USA = new Country()
                {
                    CountryName = "USA",
                    Regions = new List<Region> {California},
                };
            context.Countries.Add(Ukraine);
            context.Countries.Add(USA);

            #endregion

            #region Setting genres

            Genre Rock = new Genre
                {
                    NameOfGenre = "Rock"
                };
            context.Genres.Add(Rock);
            Genre Pop = new Genre
                {
                    NameOfGenre = "Pop"
                };
            context.Genres.Add(Pop);

            #endregion

            #region Setting logos

            Picture pic1 = new Picture
                {
                    PicturePath = "/Content/logo.jpg"
                };
            Picture pic2 = new Picture
                {
                    PicturePath = "/Content/front.jpg"
                };
            Picture pic3 = new Picture
                {
                    PicturePath = "/Content/side.jpg"
                };
            context.Pictures.Add(pic1);
            context.Pictures.Add(pic2);
            context.Pictures.Add(pic3);

            #endregion

            #region Setting info for producer

            ProducerInfo info1 = new ProducerInfo
                {
                    PhoneNumber = "(099)111-22-33",
                    Schedule = "No plans for nearest future",
                };
            ProducerInfo info2 = new ProducerInfo
                {
                    PhoneNumber = "(050)111-22-33",
                    Schedule = "Busy till the end of the week"
                };
            ProducerInfo info3 = new ProducerInfo
                {
                    PhoneNumber = "(066)111-22-33",
                    Schedule = "Just call us!"
                };

            #endregion

            #region Setting authors

            context.Authors.Add(new Author
                {
                    Email = "Test@test.com",
                    Password = "Password",
                    GeneralInfo = "General Info place...",
                    Title = "The Band!",
                    LinkToSource = "http://band.com",
                    Picture = pic1,
                    ProducerInfo = info1,
                    Country = Ukraine,
                    Genre = Rock,
                    Songs = new List<Song>{ one, two },

                });
            context.Authors.Add(new Author
                {
                    Email = "Tesdet@test.com",
                    Password = "Password",
                    GeneralInfo = "General Info place...",
                    Title = "Band 2",
                    LinkToSource = "http://2band.com",
                    Picture = pic2,
                    ProducerInfo = info2,
                    Songs = new List<Song>{ three },
                    Country = USA,
                    Genre = Rock
                });
            context.Authors.Add(new Author
                {
                    Email = "Tesddet@test.com",
                    Password = "Password",
                    GeneralInfo = "General Info place...",
                    Title = "Band 3",
                    LinkToSource = "http://3band.com",
                    Picture = pic3,
                    ProducerInfo = info3,
                    Songs = new List<Song>{ four },
                    Country = USA,
                    Genre = Rock
                });

            #endregion

            #region Setting producers

            context.Producers.Add(new Producer
                {
                    Email = "producer@email.com",
                    Password = "123",
                    PhoneNumber = "2345456",
                    FirstName = "This",
                    LastName = "Producer",
                    LinkToOrg = "http://org.com",
                    IsApproved = false,
                    Organization = "EMI",
                    ProducerId = 1
                });

            #endregion

            base.Seed(context);
        }
    }
}
