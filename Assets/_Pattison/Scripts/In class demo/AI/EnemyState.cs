﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pattison
{
    public abstract class EnemyState
    {
        protected EnemyController enemy;

        /// <summary>
        /// This method is called when switching to this state.
        /// </summary>
        /// <param name="enemy"></param>
        public virtual void OnBegin(EnemyController enemy) {
            this.enemy = enemy;
        }

        /// <summary>
        /// This method is called when switching away from this state.
        /// </summary>
        public virtual void OnEnd() {

        }

        public abstract EnemyState Update();
    }
}