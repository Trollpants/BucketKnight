// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GroundMovement.cs" company="Jan Ivar Z. Carlsen">
// Copyright (c) 2018 Jan Ivar Z. Carlsen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace BucketKnight
{
    using UnityEngine;

    public class GroundMovement : MovingObject, IDestroySelf
    {
        public Transform spawnPos;

        public void DestroySelf()
        {
            Events.instance.Raise(new GroundRemoved());
            Destroy(gameObject);
        }
    }
}
