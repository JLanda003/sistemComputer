#include <LiquidCrystal.h>

LiquidCrystal lcd(2, 3, 4, 5, 6, 7);

int lBlue =  8,
  lGreen = 9,
  lYellow = 11,
  lOrange = 12,
  lRed = 13,
  btn = 1;

int sensor = A0,
  sensBit = 0,
  sensTemp = 0;

int motor = 10, // Output 8 BITs PWM
  vel = 0; //Convert 10Bits Read to 8Bits for PWM

bool mode = false,
  msgLCD = false; //Message LCD - TurnOn and TurdOff LCD

int btnState = 0,
  lastBtnState = 0,
  outputState = 0;


void setup() {
  lcd.begin(16,2); // (column, row) size lcd panel
  lcd.clear(); // Clear LCD panel

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

  if(btnState == LOW && lastBtnState == HIGH) {
    mode = !mode;
    msgLCD = true;
    
    delay(200);
  }
  
  lastBtnState = btnState;

  if(mode && sensTemp > 0){
    
    if(msgLCD){
      lcdTurnOn();
      msgLCD = false;
    }

    lcdTempMsg();

    turnOnMotor(motor, vel);
    turnOnLeds();
  }
  else{
    if (msgLCD && !mode) {
      lcdTurnOff();
      msgLCD = false;
    }
    lcd.clear();

    reset();
    analogWrite(motor, 0);
  }
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

  if(sensTemp >= 1 && sensTemp < 21) {
    digitalWrite(lBlue, HIGH);
  }
  if(sensTemp >= 21 && sensTemp < 41) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
  }
  if(sensTemp >= 41 && sensTemp < 61) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
    digitalWrite(lYellow, HIGH);
  }
  if(sensTemp >= 61 && sensTemp < 81) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
    digitalWrite(lYellow, HIGH);
    digitalWrite(lOrange, HIGH);
  }
  if(sensTemp >= 81 && sensTemp < 100) {
    digitalWrite(lBlue, HIGH);
    digitalWrite(lGreen , HIGH);
    digitalWrite(lYellow, HIGH);
    digitalWrite(lOrange, HIGH);
    digitalWrite(lRed, HIGH);
  }
  if(sensTemp == 100) {
    digitalWrite(lRed, HIGH);
    delay(1000);
    digitalWrite(lRed, LOW);
    delay(1000);
  }
}

void lcdTurnOn(){
  lcd.setCursor(0, 0);
  lcd.print("Sistema Prendido");
  delay(1000);
  lcd.clear();
}

void lcdTurnOff(){
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("Sistema Apagado");
  delay(1000);
  lcd.clear();
}

void lcdTempMsg(){
  lcd.clear();

  if(sensTemp < 100){
    lcd.setCursor(0, 0);
    lcd.print("Temperatura de");
    lcd.setCursor(0, 1);
    lcd.print("sistema: " + String(sensTemp < 1 ? 0 : sensTemp));
  }

  if(sensTemp == 100) {
    lcd.setCursor(0, 0);
    lcd.print("Peligro Maximo,");
    lcd.setCursor(0, 1);
    lcd.print("Temperatura: " + String(sensTemp));
  }

  delay(100);
}
