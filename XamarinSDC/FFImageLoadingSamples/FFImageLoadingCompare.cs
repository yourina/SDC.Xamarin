using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using FFImageLoading.Forms;

namespace XamarinSDC
{
    public class FFImageLoadingCompare : ContentPage
    {
        public static List<string> Images = new List<string>
        {
            "https://developer.tizen.org/sites/default/files/download_side_image.png",
            "https://developer.tizen.org/sites/default/files/images/profile_wearable.png",
            "https://developer.tizen.org/sites/default/files/images/profile_tv.png",
            "https://developer.tizen.org/sites/default/files/download_side_image.png",
            "https://developer.tizen.org/sites/default/files/images/profile_wearable.png",
            "https://developer.tizen.org/sites/default/files/images/profile_tv.png",
            "https://developer.tizen.org/sites/default/files/download_side_image.png",
            "https://developer.tizen.org/sites/default/files/images/profile_wearable.png",
            "https://developer.tizen.org/sites/default/files/images/profile_tv.png",
        };
        public FFImageLoadingCompare()
        {
            Title = "CachedImage vs normal image";
            var items = new List<ImageItem>();
            for (int i = 0; i < Images.Count; i++)
            {
                items.Add(new ImageItem
                {
                    Source = Images[i],
                    Title = Images[i]
                });
            }

            Content =
                new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    Children =
                    {
                        new ListView {
                            HasUnevenRows = false,
                            RowHeight = 420,
                            ItemsSource = items,
                            ItemTemplate = new DataTemplate(() =>
                            {
                                var cell = new ViewCell();
                                var label = new Label
                                {
                                    VerticalOptions = LayoutOptions.Start,
                                    HorizontalOptions = LayoutOptions.FillAndExpand,
                                };
                                var image = new CachedImage
                                {
                                    HeightRequest = 400,
                                    ErrorPlaceholder = "error.jpg",
                                    LoadingPlaceholder = "placeholder.jpg",
                                    VerticalOptions = LayoutOptions.FillAndExpand,
                                    HorizontalOptions = LayoutOptions.FillAndExpand,
                                    Aspect = Aspect.AspectFill
                                };
                                label.SetBinding(Label.TextProperty, new Binding("Title"));
                                image.SetBinding(CachedImage.SourceProperty, new Binding("Source"));

                                cell.View = new StackLayout
                                {
                                    Children =
                                    {
                                        label,
                                        image
                                    }
                                };
                                return cell;
                            })
                        },
                        new ListView {
                            HasUnevenRows = false,
                            RowHeight = 420,
                            ItemsSource = items,
                            ItemTemplate = new DataTemplate(() =>
                            {
                                var cell = new ViewCell();
                                var label = new Label
                                {
                                    VerticalOptions = LayoutOptions.Start,
                                    HorizontalOptions = LayoutOptions.FillAndExpand,
                                };
                                var image = new Image
                                {
                                    HeightRequest = 400,
                                    VerticalOptions = LayoutOptions.FillAndExpand,
                                    HorizontalOptions = LayoutOptions.FillAndExpand,
                                    Aspect = Aspect.AspectFill
                                };
                                label.SetBinding(Label.TextProperty, new Binding("Title"));
                                image.SetBinding(Image.SourceProperty, new Binding("Source"));

                                cell.View = new StackLayout
                                {
                                    Children =
                                    {
                                        label,
                                        image
                                    }
                                };
                                return cell;
                            })
                        },
                    }
                };
        }
        class ImageItem
        {
            public ImageSource Source { get; set; }
            public string Title { get; set; }
        }
    }

}