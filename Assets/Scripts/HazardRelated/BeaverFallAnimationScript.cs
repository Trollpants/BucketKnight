// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BeaverFallAnimationScript.cs" company="Jan Ivar Z. Carlsen">
// Copyright (c) 2018 Jan Ivar Z. Carlsen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace BucketKnight
{
    using UnityEngine;

    public class BeaverFallAnimationScript : MonoBehaviour
    {
        public Animation anim;
        public AnimationClip clip;

        private void Awake()
        {
            anim.Play(clip.name);
        }
    }
}
