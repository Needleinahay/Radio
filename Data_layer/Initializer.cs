
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using Models;

namespace Data_layer
{
    public class Initializer : DropCreateDatabaseAlways<RadioContext>
    {
        protected override void Seed(RadioContext context)
        {
            Picture pic1 = new Picture { PictureId = 1, PicturePath = "/Content/logo.jpg" };
            Picture pic2 = new Picture { PictureId = 2, PicturePath = "/Content/front.jpg" };
            Picture pic3 = new Picture { PictureId = 3, PicturePath = "/Content/side.jpg" };
            List<Song> songs1 = new List<Song>();

            songs1.Add(new Song
            {
                SongId = 1,
                AuthorId = 1,
                Notes = "Some notes",
                Title = "My song",
                SongPath = "/Content/1.mp3"
            });
            songs1.Add(new Song
            {
                SongId = 2,
                AuthorId = 1,
                Notes = "Some notes!!",
                Title = "My second song",
                SongPath = "/Content/2.mp3"
            });
            List<Song> songs2 = new List<Song>();
            songs2.Add(new Song
            {
                SongId = 3,
                AuthorId = 2,
                Notes = "Some notes!!",
                Title = "My second song",
                SongPath = "/Content/01.mp3"
            });
            List<Song> songs3 = new List<Song>();
            songs3.Add(new Song
            {
                SongId = 4,
                AuthorId = 3,
                Notes = "Some notes!!",
                Title = "My second song",
                SongPath = "/Content/02.mp3"
            });


            context.Authors.Add(new Author
            {
                AuthorId = 1,
                Email = "Test@test.com",
                GeneralInfo = "General Info place...",
                Title = "The Band!",
                LinkToSource = "http://band.com",
                Picture = pic1,
                ProducerInfo = new ProducerInfo(){PhoneNumber = "123456", Schedule = "No plans"},
                Songs = songs1
            });
            context.Authors.Add(new Author
            {
                AuthorId = 2,
                Email = "Tesdet@test.com",
                GeneralInfo = "General Info place...",
                Title = "Band 2",
                LinkToSource = "http://2band.com",
                Picture = pic2,
                ProducerInfo = new ProducerInfo() { PhoneNumber = "123456", Schedule = "No plans" },
                Songs = songs2
            });
            context.Authors.Add(new Author
            {
                AuthorId = 3,
                Email = "Tesddet@test.com",
                GeneralInfo = "General Info place...",
                Title = "Band 3",
                LinkToSource = "http://3band.com",
                Picture = pic3,
                ProducerInfo = new ProducerInfo() { PhoneNumber = "123456", Schedule = "No plans" },
                Songs = songs3
            });
            context.Pictures.Add(pic1);
            context.Pictures.Add(pic2);
            context.Pictures.Add(pic3);
            context.Songs.Add(songs1[0]);
            context.Songs.Add(songs1[1]);
            context.Songs.Add(songs2[0]);
            context.Songs.Add(songs3[0]);
            context.Producers.Add(new Producer
            {
                Email = "producer@email.com",
                PhoneNumber = "2345456",
                FirstName = "This",
                LastName = "Producer",
                LinkToOrg = "http://org.com",
                IsApproved = false,
                Organization = "EMI",
                ProducerId = 1
            });
            base.Seed(context);
        }
    }
}
