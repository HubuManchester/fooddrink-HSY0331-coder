# Food Journal - Food & Drink App

## Third Submission: Hardware Features Integration

A cross-platform mobile application built with .NET MAUI for tracking food and drink nutrition, with complete hardware feature support.

## Features

### Core Features
- Two-column grid layout for food list
- Real image loading from URL (Unsplash, Pexels)
- Search functionality (name, category, description, tags)
- Add, Edit, Delete, Read food records
- Food details with calories and macros

### Hardware Features
- Camera - Capture food photos with preview
- GPS Location - Get current coordinates and address
- Text-to-Speech - Read nutrition summaries aloud
- Vibration & Haptic Feedback - Tactile feedback for actions

### UI/UX Features
- Dark/Light theme with system preference
- Large text accessibility mode
- Pull to refresh
- Floating action button
- Orange gradient header design

## Screenshots

| Light Mode | Dark Mode |
|------------|-----------|
| (Add screenshot) | (Add screenshot) |

| Hardware Page | Food Details |
|---------------|--------------|
| (Add screenshot) | (Add screenshot) |

## Technology Stack

- .NET MAUI 8.0
- C# / XAML
- CommunityToolkit.Maui for code quality
- MediaPicker, Geolocation, TextToSpeech, Vibration APIs

## How to Run

1. Open `FoodDrinkApp.sln` in Visual Studio 2022
2. Select Android emulator or physical device
3. Press F5 to build and run
4. Grant camera and location permissions when prompted

## How to Test Hardware Features

1. Tap "Hardware" tab at the bottom
2. Click "Photo" to open camera and take picture
3. Click "Locate" to get GPS coordinates and address
4. Click "Read help" to hear text-to-speech
5. Click "Haptic feedback" to feel vibration

## Project Structure

```
FoodDrinkApp/
├── Models/          - Data models
├── Services/        - Data services and API client
├── Resources/       - Styles, fonts, images
├── Converters/      - XAML value converters
├── MainPage         - Food list (two-column grid)
├── AddItemPage      - Add/Edit food form
├── FoodDetailPage   - Nutrition details
├── HardwarePage     - Camera, location, TTS, vibration
└── SettingsPage     - Theme and accessibility
```

## Bug Fix Record

### Camera Issue on Android 11+

**Problem:** Camera could not open on Android 11+ devices.

**Solution:** Added queries element to AndroidManifest.xml:

```xml
<queries>
    <intent>
        <action android:name="android.media.action.IMAGE_CAPTURE" />
    </intent>
</queries>
```

## GitHub Repository

https://github.com/HubuManchester/fooddrink-HSY0331-coder

Commit history shows three major submissions demonstrating development progress.

---

Student Project - Mobile Computing Module