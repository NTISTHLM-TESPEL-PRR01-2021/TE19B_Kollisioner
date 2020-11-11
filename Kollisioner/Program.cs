using System;
using Raylib_cs;

namespace Kollisioner
{
  class Program
  {
    static void Main(string[] args)
    {
      Raylib.InitWindow(800, 600, "Kollisioner");
      Raylib.SetTargetFPS(60);

      Color halfRed = new Color(255, 0, 0, 128);

      Rectangle first = new Rectangle(10, 10, 50, 50);
      Rectangle second = new Rectangle(35, 35, 50, 50);


      while (!Raylib.WindowShouldClose())
      {
        first.x += 1;

        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.PINK);

        Raylib.DrawRectangleRec(first, halfRed);
        Raylib.DrawRectangleRec(second, halfRed);

        if (Raylib.CheckCollisionRecs(first, second))
        {
          Raylib.DrawText("YES", 40, 540, 64, Color.WHITE);
        }
        else
        {
          Raylib.DrawText("NO", 40, 540, 64, Color.WHITE);
        }



        Raylib.EndDrawing();

      }
    }
  }
}
