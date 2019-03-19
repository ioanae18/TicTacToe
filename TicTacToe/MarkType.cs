﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
	///<summary>
	///The type of value a cell is curently at
	///</summary>

	public enum MarkType
	{
		/// <summary>
		/// The cell hasn't been clicked yet
		/// </summary>
		Free,
		/// <summary>
		/// The cell is 0
		/// </summary>
		Nought,
		/// <summary>
		/// The cell is X
		/// </summary>
		Cross
	}
}
