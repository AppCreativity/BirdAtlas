﻿using System;
using System.ComponentModel;
using BirdAtlas.Controls;
using BirdAtlas.iOS.Renderers;
using CoreAnimation;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CurvedCornersImage), typeof(CurvedCornersImageRenderer))]
namespace BirdAtlas.iOS.Renderers
{
    public class CurvedCornersImageRenderer : ImageRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == VisualElement.HeightProperty.PropertyName ||
                e.PropertyName == VisualElement.WidthProperty.PropertyName)
            {
                try
                {
                    //var maskPath = UIBezierPath.FromRoundedRect(Control.Bounds, (UIRectCorner.TopLeft|UIRectCorner.TopRight), new CGSize(10.0, 10.0));
                    //var maskLayer = new CAShapeLayer();
                    //maskLayer.Frame = Control.Bounds;
                    //maskLayer.Path = maskPath.CGPath;
                    //Control.Layer.Mask = maskLayer;

                    Control.Layer.CornerRadius = 10;
                    Control.Layer.MasksToBounds = false;
                    Control.ClipsToBounds = true;
                }
                catch (Exception ex)
                {
                    // ignored
                }
            }
        }
    }
}