using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arcanoid
{
	public class Engine
	{
		private int frameWidth;
		private int frameHeight;

		private Position cursorPosition;

		private int borderWidth = 1;

		private int sleepTimeout = 400;//ms

		private string borderSymbol = "█";

		private string cursorSymbol = "═╤═";

		private string blockSymbol = "*";

		private Position[] blockArray = new Position[10];


		public Engine(int frameWidth, int frameHeight)
		{
			this.frameHeight = frameHeight;
			this.frameWidth = frameWidth;

			this.cursorPosition.X = this.borderWidth;
			this.cursorPosition.Y = this.frameHeight - 1 - this.borderWidth;
		}

		private void ResetCursotPosition()
		{
			Console.SetCursorPosition(0, 0);
		}

		public void Run()
		{
			ConsoleKey key = ConsoleKey.NoName;
			int counter = 0;
			while (key != ConsoleKey.Escape)
			{
				CalcBlocks(counter);
				Render();
				Thread.Sleep(this.sleepTimeout);

				while (Console.KeyAvailable)
				{
					key = Console.ReadKey(true).Key;
					this.SetNewState(key);
				}
				counter++;
			}
		}

		private int GetMinXCursorPosition()
		{
			return this.borderWidth;
		}

		private int GetMaxXCursorPosition()
		{
			return this.frameWidth - 1 - this.borderWidth;
		}

		private void SetNewState(ConsoleKey key)
		{
			if (key == ConsoleKey.LeftArrow)
				this.cursorPosition.X--;

			if (key == ConsoleKey.RightArrow)
				this.cursorPosition.X++;

			if (this.cursorPosition.X < GetMinXCursorPosition())
				this.cursorPosition.X = GetMinXCursorPosition();

			if (this.cursorPosition.X > GetMaxXCursorPosition())
				this.cursorPosition.X = GetMaxXCursorPosition();
		}

		private void Render()
		{
			this.ResetCursotPosition();
			string frame = string.Empty;
			Position cellPosition = new Position();
			for (int y = 0; y < this.frameHeight; y++)
			{
				for (int x = 0; x < this.frameWidth; x++)
				{
					cellPosition.X = x;
					cellPosition.Y = y;

					frame += RenderBorderCell(cellPosition) ??
						RenderBlockCell(cellPosition) ??
							RenderCursorCell(cellPosition) ?? " ";
				}

				if (y != this.frameHeight - 1)
					frame += "\n";
			}
			Console.Write(frame);
		}

		private string RenderBorderCell(Position position)
		{
			if (IsIntoRenderZoneX(position.X) && IsIntoRenderZoneY(position.Y))
				return null;

			return borderSymbol;
		}

		private bool IsIntoRenderZoneX(int x)
		{
			return x >= this.borderWidth && x < this.frameWidth - this.borderWidth;
		}

		private bool IsIntoRenderZoneY(int y)
		{
			return y >= this.borderWidth && y < this.frameHeight - this.borderWidth;
		}

		private void CalcBlocks(int counter)
		{
			bool skipAll = false;
			for (int i = 0; i < blockArray.Length; i++)
			{
				if (blockArray[i].Y == this.frameWidth - this.borderWidth)
				{
					blockArray[i].Y = 1;
					blockArray[i].X = 0;
				}

				if (counter % 10 == 0 && blockArray[i].X==0 && !skipAll)
				{
					blockArray[i].X = this.cursorPosition.X;
					skipAll = true;
				}

				if (blockArray[i].X != 0)
					blockArray[i].Y++;
			}
		}

		private string RenderBlockCell(Position position)
		{
			for (int i = 0; i < blockArray.Length; i++)
			{
				Position blockPosition = blockArray[i];
				if (blockPosition.X == 0)
					continue;

				if(blockPosition.X == position.X && blockPosition.Y == position.Y)
					return blockSymbol;

			}
			return null;
		}

		private string RenderCursorCell(Position position)
		{
			if (position.X == this.cursorPosition.X && position.Y == this.cursorPosition.Y)
				return cursorSymbol;
			return null;
		}
	}
}
