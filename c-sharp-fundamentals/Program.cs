// Polymorphism is the ability of an object to take many forms.
// Poly = many
// Morph = forms

// List<object> vehicles = new List<object>();
// vehicles.Add(new Car 
// {
//     Brand = "Ford",
//     Model = "2020",
//     Year = 2020,
//     NumberOfDoors = 4,
// });

// List<Vehicle> vehicles = new List<Vehicle>();
List<Vehicle> vehicles =
[
    new Car 
    {
        Brand = "Ford",
        Model = "2020",
        Year = 2020,
        NumberOfDoors = 4,
    }
];

foreach (var vehicle in vehicles)
{
    // if (vehicle is Car) {
    //     var car = (Car) vehicle;
    //     car.Start();
    // }
    vehicle.Start();
}