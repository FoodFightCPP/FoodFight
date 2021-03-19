﻿using Xamarin.Forms.Internals;

namespace FoodFight.ViewModels.Forms
{
    /// <summary>
    /// ViewModel for login page.
    /// </summary>
    [Preserve(AllMembers = true)]
    public class LoginViewModel : BaseViewModel
    {
        #region Fields

        private string email;

        private bool isInvalidEmail;

        #endregion

        #region Property

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the email ID from user in the login page.
        /// </summary>
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                if (email == value)
                {
                    return;
                }

                email = value;
                OnPropertyCHanged(nameof(Email));
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the entered email is valid or invalid.
        /// </summary>
        public bool IsInvalidEmail
        {
            get
            {
                return isInvalidEmail;
            }

            set
            {
                if (isInvalidEmail == value)
                {
                    return;
                }

                isInvalidEmail = value;
                OnPropertyCHanged(nameof(IsInvalidEmail));
            }
        }

        #endregion
    }
}
