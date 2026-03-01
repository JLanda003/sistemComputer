int lBlue =  2,
  lGreen = 3,
  lYellow = 4,
  lOrange = 5,
  lRed = 6,
  btn = 13;

float sensor = A0,
  sensBit = 0,
  sensTemp = 0;

float motor = 10, // Output 8 BITs PWM
  vel = 0; //Convert 10Bits Read to 8Bits for PWM

bool mode = false;

int btnState = 0,
  lastBtnState = 0,
  outputState = 0;

void setup() {
  pinMode(lBlue, OUTPUT);
  pinMode(lGreen, OUTPUT);
  pinMode(lYellow, OUTPUT);
  pinMode(lOrange, OUTPUT);
  pinMode(lRed, OUTPUT);
  pinMode(motor, OUTPUT);

  pinMode(sensor, INPUT);
  pinMode(btn, INPUT);
}

void loop() {
  sensBit = analogRead(sensor);
  sensTemp = convertBitToTemp(sensBit); //Convert Bits value to grades Celsius

  vel = convertBitToVelocity(sensBit);
  
  btnState = digitalRead(btn);

  if(btnState == HIGH && lastBtnState == LOW) {
    mode = !mode;

    delay(200);
  }
  
  lastBtnState = btnState;

  if(mode){
    turnOnMotor(motor, vel);
    turnOnLeds();
  }
  else
    reset();

}

float convertBitToTemp(float sensBit) {
  return (sensBit * 100) / 1023;
}

float convertBitToVelocity(float sensBit){
  return sensBit/4;
}

void reset() {
  digitalWrite(lBlue, LOW);
  digitalWrite(lGreen , LOW);
  digitalWrite(lYellow, LOW);
  digitalWrite(lOrange, LOW);
  digitalWrite(lRed, LOW);
};

void turnOnMotor(float motor, float vel){
  analogWrite(motor, vel);
}

void turnOnLeds() {
  reset();

  if(sensTemp < 20) {
    digitalWrite(lBlue, HIGH);
  }
  else if(sensTemp < 40) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
  }
  else if(sensTemp < 60) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
    digitalWrite(lYellow, HIGH);
  }
  else if(sensTemp < 80) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
    digitalWrite(lYellow, HIGH);
    digitalWrite(lOrange, HIGH);
  }
  else if(sensTemp < 100) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
    digitalWrite(lYellow, HIGH);
    digitalWrite(lOrange, HIGH);
    digitalWrite(lRed, HIGH);
  }
}
