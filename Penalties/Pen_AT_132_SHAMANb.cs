using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Pen_AT_132_SHAMANb : PenTemplate //searingtotem
	{
		public override float getPlayPenalty(Playfield p, Handmanager.Handcard hc, Minion target, int choice, bool isLethal)
		{
			return 0;
		}
	}
}
