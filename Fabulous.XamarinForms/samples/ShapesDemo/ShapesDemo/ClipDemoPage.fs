namespace ShapesDemo

open Fabulous.XamarinForms
open Xamarin.Forms
open Xamarin.Forms.Shapes

module ClipDemoPage =
    [<Literal>]
    let figures = "M 75.6446,45 C 72.2146,45.0073 68.857,46.9543 67.1304,49.9245 L 40.2748,96.5755 C 38.5751,99.5537 38.5751,103.446 40.2748,106.424 L 67.1304,153.076 C 68.8572,156.046 72.2146,157.993 75.6446,158 L 129.355,158 C 132.785,157.993 136.143,156.046 137.87,153.076 L 164.725,106.424 C 166.425,103.446 166.425,99.5537 164.725,96.5755 L 137.87,49.9245 C 136.143,46.9543 132.785,45.0067 129.355,45 L 75.6446,45 75.6446,45 Z M 76.132,72.2914 C 76.2058,72.2841 76.2832,72.2841 76.3572,72.2914 L 85.6215,72.2914 C 86.0316,72.2999 86.4294,72.5369 86.6342,72.8929 L 102.35,100.899 C 102.429,101.037 102.48,101.191 102.499,101.35 102.519,101.191 102.57,101.037 102.649,100.899 L 118.327,72.8929 C 118.538,72.5261 118.955,72.2878 119.377,72.2914 L 128.641,72.2914 C 129.462,72.2987 130.076,73.332 129.692,74.0582 L 114.351,101.5 129.692,128.904 C 130.113,129.635 129.483,130.716 128.641,130.709 L 119.377,130.709 C 118.947,130.705 118.528,130.45 118.327,130.07 L 102.649,102.064 C 102.57,101.925 102.519,101.771 102.499,101.613 102.48,101.771 102.429,101.925 102.35,102.064 L 86.6342,130.07 C 86.4387,130.439 86.0388,130.692 85.6215,130.709 L 76.3572,130.709 C 75.5156,130.716 74.8863,129.635 75.3071,128.904 L 90.6476,101.5 75.3071,74.0582 C 74.9394,73.3956 75.388,72.4329 76.132,72.2914 L 76.132,72.2914 Z"
    
    let view () =
        View.ContentPage(
            title = "Clipping demos",
            content = View.ScrollView(
                View.StackLayout(
                    margin = Thickness(20.),
                    children = [
                        View.Label(
                            text = "Unclipped image"
                        )
                        View.Image(
                            source = Image.fromPath "monkeyface.png"
                        )
                        View.Label(
                            text = "Clipped image with RectangleGeometry"
                        )
                        View.Image(
                            source = Image.fromPath "monkeyface.png",
                            clip = View.RectangleGeometry(
                                rect = Xamarin.Forms.Rectangle(40., 100., 300., 150.)
                            )
                        )
                        View.Label(
                            text = "Clipped image with EllipseGeometry"
                        )
                        View.Image(
                            source = Image.fromPath "monkeyface.png",
                            clip = View.EllipseGeometry(
                                radiusX = 100.,
                                radiusY = 100.,
                                center = Point(180., 180.)
                            )
                        )
                        View.Label(
                            text = "Clipped image with GeometryGroup"
                        )
                        View.Image(
                            source = Image.fromPath "monkeyface.png",
                            clip = View.GeometryGroup(
                                fillRule = FillRule.EvenOdd,
                                children = [
                                    View.EllipseGeometry(radiusX = 100., radiusY = 100., center = Point(150., 150.))
                                    View.EllipseGeometry(radiusX = 100., radiusY = 100., center = Point(250., 150.))
                                    View.EllipseGeometry(radiusX = 100., radiusY = 100., center = Point(150., 250.))
                                    View.EllipseGeometry(radiusX = 100., radiusY = 100., center = Point(250., 250.))
                                ]
                            )
                        )
                        View.Label(
                            text = "Clipped image with PathGeometry"
                        )
                        View.Image(
                            source = Image.fromPath "monkeyface.png",
                            clip = View.PathGeometry(
                                figures = Figures.fromString figures
                            )
                        )
                    ]
                )
            )
        )

