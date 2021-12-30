using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        public ComicBook[] GetComicBooks()
        {
            return _comicBooks.OrderBy(x => x.SeriesTitle).ToArray();
        }

        public ComicBook GetComicBook(int id)
        {
            foreach (ComicBook comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    return comicBook;
                }
            }
            return null;
        }
      
        public Venta[] GetVentasComics()
        {
            return _ventas.OrderBy( r=> Guid.NewGuid()).Skip(0).Take(2).ToArray(); ;
        }
        private static Venta[] _ventas = new Venta[]
        {
            new Venta ()
            {
                Id = 1,
                Cantidad = 4,
                ComicBook =  new ComicBook()
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters" },
                },
                Favorite = false
            },
                Valor = 12.50,
                FechaVenta = DateTime.Now
            },
            new Venta ()
            {
                Id = 2,
                Cantidad = 7,
                ComicBook = new ComicBook()
            {
                Id =4 ,
                SeriesTitle = "Linterna Verde",
                IssueNumber = 350,
                DescriptionHtml = "<p><strong>Linterna Verde (en inglés: Green Lantern).</strong> es el alias de varios superhéroes de la ficción del Universo DC, de la editorial DC Comics, los cuales se caracterizan por portar un anillo de poder y tener la capacidad de crear manifestaciones de luz sólida con dichos anillos.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Alan Scott", Role = "Script" },
                    new Artist() { Name = "Hal Jordan", Role = "Pencils" },
                    new Artist() { Name = "Guy Gardner", Role = "Inks" },
                    new Artist() { Name = "Jessica Cruz", Role = "Letters" }
                },
                Favorite = false
            },
                Valor = 19.50,
                FechaVenta = DateTime.Now
            },
            new Venta()
            {
                Id=3,
                Cantidad= 15,
                ComicBook = new ComicBook()
            {
                Id = 3,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Artist() { Name = "Jeff Smith", Role = "Letters" }
                },
                Favorite = false
            },
                Valor = 16.75,
                FechaVenta = DateTime.Now,
            }

        };
      
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook()
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters" },
                },
                Favorite = false
            },
            new ComicBook()
            {
                Id = 2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Marcos Martin", Role = "Pencils" },
                    new Artist() { Name = "Marcos Martin", Role = "Inks" },
                    new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
                    new Artist() { Name = "Joe Caramagna", Role = "Letters" }
                },
                Favorite = false
            },
            new ComicBook()
            {
                Id = 3,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Artist() { Name = "Jeff Smith", Role = "Letters" }
                },
                Favorite = false
            },
            new ComicBook()
            {
                Id =4 ,
                SeriesTitle = "Linterna Verde",
                IssueNumber = 350,
                DescriptionHtml = "<p><strong>Linterna Verde (en inglés: Green Lantern).</strong> es el alias de varios superhéroes de la ficción del Universo DC, de la editorial DC Comics, los cuales se caracterizan por portar un anillo de poder y tener la capacidad de crear manifestaciones de luz sólida con dichos anillos.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Alan Scott", Role = "Script" },
                    new Artist() { Name = "Hal Jordan", Role = "Pencils" },
                    new Artist() { Name = "Guy Gardner", Role = "Inks" },
                    new Artist() { Name = "Jessica Cruz", Role = "Letters" }
                },
                Favorite = false
            }
        };
    }
}