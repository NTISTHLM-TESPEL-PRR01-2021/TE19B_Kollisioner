using System.Runtime.InteropServices;
using System;
using System.Numerics;
using Raylib_cs;
using System.Collections.Generic;

namespace Kollisioner
{
  class Program
  {
    class Enemy
    {
      public Rectangle rect = new Rectangle();
      public Vector2 velocity = new Vector2(1, 1);
      public Color color = Color.PURPLE;
    }


    static void Main(string[] args)
    {
      int test = 99;

      int test1b = 100;

      Console.WriteLine(test);

      // List<string> names = new List<string>();

      // names.Add("Micke");
      // names.Add("Sara");
      // names.Add("Eva");
      // names.Add("Kim");

      // Random generator = new Random();
      // int nameInt = generator.Next(names.Count);


      // Console.WriteLine( names[nameInt] );


      Raylib.InitWindow(800, 600, "Kollisioner");
      Raylib.SetTargetFPS(60);

      Font cNeue = Raylib.LoadFont("ComicNeue-Bold.ttf");

      Color halfRed = new Color(255, 0, 0, 128);

      // List<Rectangle> enemies = new List<Rectangle>();

      // enemies.Add(new Rectangle(0,0, 30,30));
      // enemies.Add(new Rectangle(60,60, 30,30));
      // enemies.Add(new Rectangle(100,100, 30,30));

      Enemy enemy1 = new Enemy();
      enemy1.color = Color.GREEN;
      enemy1.rect = new Rectangle(10, 50, 30, 30);


      Enemy enemy2 = new Enemy();
      enemy2.color = Color.LIGHTGRAY;
      enemy2.rect = new Rectangle(70, 90, 30, 30);

      // Enemy e3 = new Enemy();
      // e3.color = Color.YELLOW;
      // e3.rect = new Rectangle(100, 190, 30, 30);

      List<Enemy> enemies = new List<Enemy>();
      enemies.Add(enemy1);
      enemies.Add(enemy2);


      Rectangle ballRect = new Rectangle(200, 200, 20, 20);
      Vector2 ballSpeed = new Vector2(1, 1);



      Rectangle first = new Rectangle(10, 10, 50, 50);
      Rectangle second = new Rectangle(35, 35, 50, 50);


      while (!Raylib.WindowShouldClose())
      {
        first.x += 1;

        ballRect.x += ballSpeed.X;
        ballRect.y += ballSpeed.Y;



        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.PINK);

        Raylib.DrawRectangleRec(first, halfRed);
        Raylib.DrawRectangleRec(second, halfRed);

        for (int i = 0; i < enemies.Count; i++)
        {
          enemies[i].rect.x += enemies[i].velocity.X;
          enemies[i].rect.y += enemies[i].velocity.Y;

          Raylib.DrawRectangleRec(enemies[i].rect, enemies[i].color);
        }

        //Raylib.DrawRectangleRec(ballRect, Color.GOLD);


        // int i = 0;
        // while (i < enemies.Count)
        // {
        //   i++;
        // }




        Vector2 pos = new Vector2(40, 540);

        if (Raylib.CheckCollisionRecs(first, second))
        {
          //Raylib.DrawText("YES", 40, 540, 64, Color.WHITE);
          Raylib.DrawTextEx(cNeue, "YES", pos, 64, 0, Color.WHITE);
        }
        else
        {
          Raylib.DrawTextEx(cNeue, "NO", pos, 64, 0, Color.WHITE);
        }



        Raylib.EndDrawing();

      }
    }
  }
}
