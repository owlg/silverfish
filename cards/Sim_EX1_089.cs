// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_EX1_089.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ e x 1_089.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    using System;

    /// <summary>
    ///     The sim_ e x 1_089.
    /// </summary>
    internal class Sim_EX1_089 : SimTemplate
    {
        // arcanegolem

        // ansturm/. kampfschrei:/ gebt eurem gegner 1 manakristall.
        #region Public Methods and Operators

        /// <summary>
        /// The get battlecry effect.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        /// <param name="own">
        /// The own.
        /// </param>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <param name="choice">
        /// The choice.
        /// </param>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                p.enemyMaxMana = Math.Min(10, p.enemyMaxMana + 1);
            }
            else
            {
                p.ownMaxMana = Math.Min(10, p.ownMaxMana + 1);
            }
        }

        #endregion
    }
}