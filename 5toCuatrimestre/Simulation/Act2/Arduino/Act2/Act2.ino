int lGreen = 2, lYellow = 4, lRed = 6;
int arr[6] = {2,2,4,4,6,6};
int lenght = sizeof(arr) / sizeof(arr[0]);

void setup() {
  pinMode(lGreen, OUTPUT);
  pinMode(lYellow, OUTPUT);
  pinMode(lRed, OUTPUT);
}

void loop() {
  bool state = false;
  for (int i=0; i <= lenght; i++){
    digitalWrite(arr[i], !state);
    state = !state;
    delay(1000);
  }
  state = false;
}
