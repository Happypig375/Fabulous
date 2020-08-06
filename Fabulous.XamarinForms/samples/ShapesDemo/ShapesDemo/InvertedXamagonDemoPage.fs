namespace ShapesDemo

open Fabulous.XamarinForms
open Xamarin.Forms

module InvertedXamagonDemoPage =
    
    let view () =
        View.ContentPage(
            title = "Inverted Xamagon demo",
            content = View.Grid(
                horizontalOptions = LayoutOptions.Center,
                verticalOptions = LayoutOptions.Center,
                children = [
                    View.Rectangle(
                        fill = Color.FromHex("#298069"),
                        width = 203.,
                        height = 203.
                    )
                    View.Path(
                        fill = Color.FromHex("#FFFFFF"),
                        data = Content.fromString "M75.64462,45 C72.2146221,45.0072736 68.8570407,46.9542688 67.1303574,49.9244767 L40.2748461,96.5755051 C38.5750513,99.5536654 38.5750513,103.446335 40.2748461,106.424495 L67.1303574,153.075523 C68.8572221,156.045755 72.2146221,157.993272 75.64462,158 L129.355453,158 C132.785451,157.992726 136.142849,156.045755 137.869714,153.075523 L164.725221,106.424495 C166.425014,103.446335 166.424839,99.5536654 164.725221,96.5755051 L137.869714,49.9244767 C136.142849,46.9542688 132.785451,45.0067281 129.355453,45 L75.64462,45 L75.64462,45 Z M76.1320485,72.2914163 C76.2058317,72.2841427 76.2832193,72.2841427 76.3572323,72.2914163 L85.6215431,72.2914163 C86.0316324,72.2999021 86.4294204,72.5369 86.634211,72.8928696 L102.350001,100.898541 C102.429106,101.037006 102.480077,101.191278 102.499418,101.349625 C102.518771,101.191242 102.569693,101.036957 102.648835,100.898541 L118.327009,72.8928696 C118.538298,72.5261109 118.95472,72.2878037 119.37712,72.2914163 L128.641435,72.2914163 C129.4618,72.2986899 130.076151,73.3319643 129.69172,74.0582204 L114.351216,101.500006 L129.69172,128.904199 C130.112538,129.634626 129.48307,130.715809 128.641435,130.708584 L119.37712,130.708584 C118.947338,130.704947 118.528454,130.450153 118.327009,130.069538 L102.648835,102.063867 C102.569729,101.925402 102.518759,101.771117 102.499418,101.612783 C102.480065,101.771153 102.429142,101.925463 102.350001,102.063867 L86.634211,130.069538 C86.4387461,130.439388 86.0388414,130.691745 85.6215431,130.708584 L76.3572323,130.708584 C75.5155962,130.715857 74.8862984,129.634626 75.3071165,128.904199 L90.647616,101.500006 L75.3071165,74.0582204 C74.939386,73.3955961 75.388036,72.4328513 76.1320485,72.2914163 L76.1320485,72.2914163 Z"
                    )
                ]
            )
        )

