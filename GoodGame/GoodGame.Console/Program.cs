// See https://aka.ms/new-console-template for more information
using GoodGame.Logic;

Card card = new Card();
FieldSurface fieldSurface = new FieldSurface(25);
fieldSurface.SelectCardsRandomized(30);
Console.WriteLine(fieldSurface.Cards.Count);