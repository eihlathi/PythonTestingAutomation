class Car {
    make;
    model;
    topSpeed;
    engineRunning;
    currentSpeed;

    startEngine() {
        this.engineRunning = true;
    }

    accelerate() {
        if (this.engineRunning) {
            this.currentSpeed += 10; 
        }
    }
}

let myCar = new Car();
myCar.make = "Toyota";
myCar.startEngine();
console.log(myCar.engineRunning);
