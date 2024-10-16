class Car {
    constructor(make, model, topSpeed) {
      this.make = make;
      this.model = model;
      this.topSpeed = topSpeed;
      this._engineRunning = false;
      this._currentSpeed = 0;
    }
  
    startEngine() {
      this._engineRunning = true;
      console.log("Engine started.");
    }
  
    stopEngine() {
      if (this._currentSpeed === 0) {
        this._engineRunning = false;
        console.log("Engine stopped.");
      } else {
        console.log("Cannot stop engine while the car is moving.");
      }
    }
  
    accelerate() {
      if (this._engineRunning) {
        if (this._currentSpeed + 10 <= this.topSpeed) {
          this._currentSpeed += 10;
          console.log(`Accelerated. Current speed is ${this._currentSpeed} km/h.`);
        } else {
          this._currentSpeed = this.topSpeed;
          console.log(`Accelerated. Current speed is ${this._currentSpeed} km/h (top speed).`);
        }
      } else {
        console.log("Cannot accelerate. Engine is not running.");
      }
    }
  
    decelerate() {
      if (this._currentSpeed - 10 >= 0) {
        this._currentSpeed -= 10;
        console.log(`Decelerated. Current speed is ${this._currentSpeed} km/h.`);
      } else {
        this._currentSpeed = 0;
        console.log(`Decelerated. Current speed is ${this._currentSpeed} km/h (minimum speed).`);
      }
    }
  
    get engineRunning() {
      return this._engineRunning;
    }
  
    get currentSpeed() {
      return this._currentSpeed;
    }
  }
  
  // Example usage:
  const myCar = new Car('Toyota', 'Corolla', 180);
  myCar.startEngine();
  myCar.accelerate();
  myCar.accelerate();
  myCar.decelerate();
  myCar.stopEngine();
  