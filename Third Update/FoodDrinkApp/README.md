# Food Journal App

## Third Submission - Hardware Features Version

### What's New in This Submission

- Camera Integration - Take food photos and preview them
- GPS Location - Get current coordinates and reverse geocoding address
- Text-to-Speech - Read nutrition summaries and help text aloud
- Vibration and Haptic Feedback - Tactile feedback for button clicks
- New Hardware Tab - Dedicated page for all hardware demonstrations

### Hardware Features Overview

| Feature | How to Test | Expected Result |
|---------|-------------|-----------------|
| Camera | Click "Photo" button | Camera opens, photo appears in preview area |
| Location | Click "Locate" button | Coordinates and address are displayed |
| Text-to-Speech | Click "Read help" button | Phone speaks the help text |
| Vibration | Click "Haptic feedback" button | Phone vibrates, counter increases |

### Permissions Required

When you first use these features, the app will request:

- Camera permission (for taking photos)
- Location permission (for GPS coordinates)

If you accidentally deny permissions, you can enable them in your device settings:
Settings -> Apps -> Food Journal -> Permissions

### Current Status

| Feature | Status |
|---------|--------|
| Food List (Grid Layout) | Complete |
| Real Image Loading | Complete |
| Search | Complete |
| Add New Food | Complete |
| Edit Food | Complete |
| Delete Food | Complete |
| Dark/Light Theme | Complete |
| Large Text Mode | Complete |
| Camera | Complete |
| GPS Location | Complete |
| Text-to-Speech | Complete |
| Vibration / Haptic | Complete |

### Testing Checklist for Hardware

Before submitting, verify these items:

Camera:
- [ ] Camera opens when "Photo" is clicked
- [ ] Permission popup appears
- [ ] Photo can be taken
- [ ] Photo appears in preview area

Location:
- [ ] "Locate" button triggers location request
- [ ] Permission popup appears
- [ ] Coordinates are displayed (Latitude, Longitude)
- [ ] Address information is displayed

Text-to-Speech:
- [ ] "Read help" button triggers speech
- [ ] Phone audio plays the message
- [ ] "Stop speech" button stops the audio

Vibration:
- [ ] "Haptic feedback" button triggers vibration
- [ ] Counter increments on each click
- [ ] Vibration is noticeable

### Build and Run
dotnet clean
dotnet restore
dotnet build

### Run on Android device
dotnet build -f net8.0-android


### Troubleshooting

Camera not working?
- Check camera permission in device settings
- Make sure no other app is using the camera

Location not working?
- Enable GPS on your device
- Check location permission in device settings
- Try being outdoors for better GPS signal

Text-to-Speech not working?
- Check device volume is not muted
- Check TTS engine is installed on device

Vibration not working?
- Check device is not in silent mode
- Some devices may disable vibration in battery saver mode

### Hardware Page Layout

The Hardware page is organized into sections:

1. Food Photo - Camera capture and preview
2. Meal Location - GPS coordinates and address
3. Speech Controls - Read help and stop speech
4. Haptic Feedback - Vibration test with counter

### Next Steps

All core and hardware features are now complete. The app is ready for final testing and video recording.

---

For more details, see the main README in the project root.