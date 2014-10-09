// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_EX1_390.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ e x 1_390.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    ///     The sim_ e x 1_390.
    /// </summary>
    internal class Sim_EX1_390 : SimTemplate
    {
        // taurenwarrior

        // spott/, wutanfall:/ +3 angriff
        #region Public Methods and Operators

        /// <summary>
        /// The on enrage start.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        /// <param name="m">
        /// The m.
        /// </param>
        public override void onEnrageStart(Playfield p, Minion m)
        {
            m.Angr += 3;
        }

        /// <summary>
        /// The on enrage stop.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        /// <param name="m">
        /// The m.
        /// </param>
        public override void onEnrageStop(Playfield p, Minion m)
        {
            m.Angr -= 3;
        }

        #endregion
    }
}