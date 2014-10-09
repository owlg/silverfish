﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sim_CS2_083b.cs" company="">
//   
// </copyright>
// <summary>
//   The sim_ c s 2_083 b.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace HREngine.Bots
{
    /// <summary>
    ///     The sim_ c s 2_083 b.
    /// </summary>
    internal class Sim_CS2_083b : SimTemplate
    {
        // daggermastery

        // heldenfähigkeit/\nlegt einen dolch (1/2) an.
        #region Fields

        /// <summary>
        ///     The weapon.
        /// </summary>
        private CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_082);

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The on card play.
        /// </summary>
        /// <param name="p">
        /// The p.
        /// </param>
        /// <param name="ownplay">
        /// The ownplay.
        /// </param>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <param name="choice">
        /// The choice.
        /// </param>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(this.weapon, ownplay);
        }

        #endregion
    }
}