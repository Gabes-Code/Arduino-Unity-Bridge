void setup() {
  Serial.begin(9600); // Make sure Unity uses the same baud rate
}

void loop() {
  int sensorValue = analogRead(A0);
  Serial.println(sensorValue); // Send data to Unity
  delay(100); // Send data every 100ms
}
