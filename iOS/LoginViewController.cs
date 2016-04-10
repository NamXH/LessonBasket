﻿using System;
using UIKit;

namespace LessonBasket.iOS
{
    public class LoginViewController : UIViewController
    {
        public LoginViewController()
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "Login";
            View.BackgroundColor = UIColor.White;

            var username = new UITextField
            {
                Placeholder = "Username",
                BorderStyle = UITextBorderStyle.RoundedRect,
            };
            View.AddSubview(username);
            username.Layer.BorderColor = UIColor.Gray.CGColor;
            username.Layer.BorderWidth = UIConstants.BorderWidth;
            username.Layer.CornerRadius = UIConstants.CornerRadius;

            var password = new UITextField
            {
                Placeholder = "Password",
                BorderStyle = UITextBorderStyle.RoundedRect,
                SecureTextEntry = true,
            };
            View.AddSubview(password);
            password.Layer.BorderColor = UIColor.Gray.CGColor;
            password.Layer.BorderWidth = UIConstants.BorderWidth;
            password.Layer.CornerRadius = UIConstants.CornerRadius;

            var loginButton = new UIButton(UIButtonType.System)
            {
                BackgroundColor = View.TintColor,
                Font = UIFont.FromName("Helvetica-Bold", UIConstants.NormalFontSize),
            };
            View.AddSubview(loginButton);
            loginButton.SetTitle("Login", UIControlState.Normal);
            loginButton.SetTitleColor(UIColor.White, UIControlState.Normal);
            loginButton.Layer.CornerRadius = UIConstants.CornerRadius;
            loginButton.TouchUpInside += (sender, e) =>
            {
                NavigationController.PushViewController(new AbcViewController(), true);
            };

            var signUpButton = new UIButton(UIButtonType.System)
            {
                BackgroundColor = UIColor.LightGray,
                Font = UIFont.FromName("Helvetica-Bold", UIConstants.NormalFontSize),
            };
            View.AddSubview(signUpButton);
            signUpButton.SetTitle("Sign Up", UIControlState.Normal);
            signUpButton.SetTitleColor(UIColor.White, UIControlState.Normal);
            signUpButton.Layer.CornerRadius = UIConstants.CornerRadius;

            #region UI Layout
            var topPad = (float)NavigationController.NavigationBar.Frame.Size.Height + UIConstants.VerticalPad + 30f;

            View.ConstrainLayout(() =>
                username.Frame.Top == View.Frame.Top + topPad &&
                username.Frame.Left == View.Frame.Left + UIConstants.HorizontalPad &&
                username.Frame.Right == View.Frame.Right - UIConstants.HorizontalPad &&
                username.Frame.Height == UIConstants.ControlsHeight &&

                password.Frame.Top == username.Frame.Bottom + 20f &&
                password.Frame.Left == View.Frame.Left + UIConstants.HorizontalPad &&
                password.Frame.Right == View.Frame.Right - UIConstants.HorizontalPad &&
                password.Frame.Height == UIConstants.ControlsHeight &&

                loginButton.Frame.Top == password.Frame.Bottom + 40f &&
                loginButton.Frame.Left == View.Frame.Left + UIConstants.HorizontalPad &&
                loginButton.Frame.Right == View.Frame.Right - UIConstants.HorizontalPad &&
                loginButton.Frame.Height == UIConstants.ControlsHeight &&

                signUpButton.Frame.Top == loginButton.Frame.Bottom + 20f &&
                signUpButton.Frame.Left == View.Frame.Left + UIConstants.HorizontalPad &&
                signUpButton.Frame.Right == View.Frame.Right - UIConstants.HorizontalPad &&
                signUpButton.Frame.Height == UIConstants.ControlsHeight 
            );
            #endregion
        }
    }
}