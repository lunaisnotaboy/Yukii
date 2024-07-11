using System;
using UnityEngine;

public class Clock : MonoBehaviour {
  [SerializeField]
  private Transform hoursPivot;

  private const float hoursToDegrees = -30f;

  [SerializeField]
  private Transform minutesPivot;

  private const float minutesToDegrees = -6f;

  [SerializeField]
  private Transform secondsPivot;

  private const float secondsToDegrees = -6f;

  // `Start` is called before the first frame update
  void Start() {}

  // `Update` is called once per frame
  void Update() {
    TimeSpan time = DateTime.Now.TimeOfDay;

    hoursPivot.localRotation = Quaternion.Euler(
      0f,
      0f,
      (float)time.TotalHours * hoursToDegrees
    );

    minutesPivot.localRotation = Quaternion.Euler(
      0f,
      0f,
      (float)time.TotalMinutes * minutesToDegrees
    );

    secondsPivot.localRotation = Quaternion.Euler(
      0f,
      0f,
      (float)time.TotalSeconds * secondsToDegrees
    );
  }
}
