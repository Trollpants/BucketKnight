﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LogoTweener.cs" company="Jan Ivar Z. Carlsen">
// Copyright (c) 2018 Jan Ivar Z. Carlsen. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace BucketKnight
{
    using DG.Tweening;
    using DG.Tweening.Core;
    using DG.Tweening.Plugins.Options;
    using UnityEngine;

    /// <summary>
    ///  Animates the logo on the main menu with tweening
    /// </summary>
    [RequireComponent(typeof(RectTransform))]
    public class LogoTweener : MonoBehaviour
    {
        #region Fields & properties

        private RectTransform _rectTransform;
        private TweenerCore<Vector2, Vector2, VectorOptions> tweener1;
        private TweenerCore<Quaternion, Vector3, QuaternionOptions> tweener2;

        #endregion /Fields & properties

        #region Public methods

        #endregion /Public methods

        #region Unity methods

        private void Awake()
        {
            Time.timeScale = 1;
            _rectTransform = GetComponent<RectTransform>();
        }

        private void Start()
        {
            tweener1 = DOTween.To(() => _rectTransform.anchoredPosition, x => _rectTransform.anchoredPosition = x, new Vector2(0, 32f), 3.5f)
                .SetRelative(true)
                .SetEase(Ease.InOutQuad)
                .SetLoops(-1, LoopType.Yoyo);
            tweener2 = _rectTransform.DORotate(new Vector3(0f, 0f, -1f), 2.25f).SetEase(Ease.InOutQuad).SetLoops(-1, LoopType.Yoyo);
        }

        private void OnDestroy()
        {
            tweener1?.Kill();
            tweener2?.Kill();
        }

        #endregion /Unity methods

        #region Private methods

        #endregion / Private methods
    }
}
