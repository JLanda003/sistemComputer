int ledBlue = 13;

void setup() {
  pinMode(ledBlue, OUTPUT);  // Asignar a ledBlue como trabajara.
}

void loop() {
  digitalWrite(ledBlue, HIGH);
  delay(500);

  digitalWrite(ledBlue, LOW);
  delay(500);
}
