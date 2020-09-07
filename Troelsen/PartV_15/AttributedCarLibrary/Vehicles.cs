// List "using" statements first.
using System;
using System.Collections.Generic;
using System.Text;

// Now list any assembly- or module-level attributes.
// Enforce CLS compliance for all public types in this assembly.
[assembly: CLSCompliant(true)]
// Now, your namespace(s) and types.
namespace AttributedCarLibrary
{
    [Serializable]
    [VehicleDescription(Description = "My rocking Harley")]
    public class Motorcycle
    {

    }
    [Serializable]
    [Obsolete("Use another vehicle!")]
    [VehicleDescription("The old gray mare, she ain't what she used to be...")]
    public class HorseAndBuggy
    {

    }
    [VehicleDescription("A very long, slow, but feature-rich auto")]
    public class Winnebago
    {

    }
}
