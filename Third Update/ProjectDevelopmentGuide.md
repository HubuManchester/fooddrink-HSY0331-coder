# Food Journal - Project Development Documentation

## Project Overview

Food Journal is a cross-platform mobile application built with .NET MAUI for the Mobile Computing module. The app helps users track food and drink nutrition, record meals with photos, and access nutrition information.

## Development Timeline

### First Submission: Main Interface (June 2, 2026)

Implemented features:
- Two-column grid layout for food list display
- CollectionView with custom food cards
- Pull-to-refresh functionality
- Add new food form with validation
- Food detail page with nutrition information
- Dark/Light theme support
- Large text accessibility mode
- Floating action button for adding food

### Second Submission: Image Loading (June 2, 2026)

Implemented features:
- Real image loading from URL (Unsplash, Pexels)
- Image URL input in add/edit form
- Category emoji fallback for missing images
- Search functionality (name, category, description, tags)
- IsNullOrEmptyConverter for image binding
- README documentation update

### Third Submission: Hardware Features (June 3, 2026)

Implemented hardware features:
- Camera integration (MediaPicker)
- GPS location (Geolocation + Geocoding)
- Text-to-Speech (TextToSpeech)
- Vibration and Haptic Feedback

Hardware testing device: Huawei Nova 11, HarmonyOS 4.2.0

## Bug Fix Record

### Bug: Camera Not Working on Android 11+

**Problem Description:**
When clicking the Photo button on Hardware page, the app displayed error: "Either there was no camera on the device or android.media.action.IMAGE_CAPTURE was not added to the queries element"

**Root Cause:**
Android 11 (API 30) introduced package visibility restrictions. Apps cannot query other packages by default. MediaPicker needs to know which camera app can handle the intent.

**Solutions Attempted:**
1. Manually grant camera permission in device settings - Not working
2. Add runtime permission request in code - Not working
3. Final solution: Add queries element to AndroidManifest.xml - Working

**Final Fix Code:**
```xml
<queries>
    <intent>
        <action android:name="android.media.action.IMAGE_CAPTURE" />
    </intent>
</queries>
```

**Result:**
Camera works normally. Users can take photos and preview them in the app.

## Technology Stack

| Technology | Version | Purpose |
|------------|---------|---------|
| .NET MAUI | 8.0 | Cross-platform framework |
| C# | 12.0 | Programming language |
| XAML | - | UI markup language |
| CommunityToolkit.Maui | 8.0.1 | Code quality analyzer |
| HttpClient | - | API communication |
| MediaPicker | - | Camera functionality |
| Geolocation | - | GPS location |
| TextToSpeech | - | Voice output |
| Vibration | - | Haptic feedback |

## Project Structure

```
FoodDrinkApp/
├── Models/
│   └── FoodItem.cs           - Data model
├── Services/
│   ├── FoodCatalogService.cs - Data service (Mock API + local)
│   ├── AccessibilityService.cs - Large text mode
│   ├── SpeechService.cs      - Text-to-speech
│   └── MockApiConfig.cs      - API configuration
├── Converters/
│   └── IsNullOrEmptyConverter.cs - XAML value converter
├── Resources/Styles/
│   ├── Colors.xaml           - Color definitions
│   └── Styles.xaml           - Global styles
├── MainPage.xaml             - Food list (two-column grid)
├── AddItemPage.xaml          - Add/Edit food form
├── FoodDetailPage.xaml       - Nutrition details
├── HardwarePage.xaml         - Hardware demo page
├── SettingsPage.xaml         - Theme and accessibility
└── AppShell.xaml             - Navigation shell
```

## Code Quality Measures

1. **Naming Conventions:**
   - Classes: PascalCase (e.g., FoodItem)
   - Methods: PascalCase (e.g., LoadFoodItemsAsync)
   - Variables: camelCase (e.g., currentItem)
   - Private fields: camelCase (e.g., feedbackTestCount)

2. **Error Handling:**
   - All async operations use try-catch
   - User-friendly error messages (no technical jargon)
   - Graceful degradation (local fallback when API fails)

3. **Code Reusability:**
   - Service classes for data operations
   - Static methods for shared services
   - XAML styles for consistent UI

4. **Third-party Tools:**
   - CommunityToolkit.Maui.Analyzers for code quality checking

## Testing Summary

| Test Category | Status | Notes |
|---------------|--------|-------|
| UI/UX | Pass | Two-column grid, gradient header, responsive |
| Dark/Light Theme | Pass | Follows system preference |
| Large Text Mode | Pass | Text scales 1.22x |
| Search | Pass | Searches name, category, description, tags |
| CRUD Operations | Pass | Add, edit, delete, read all work |
| Camera | Pass | Requires queries element for Android 11+ |
| GPS Location | Pass | Returns coordinates and address |
| Text-to-Speech | Pass | Reads help text and nutrition summary |
| Vibration | Pass | Triggers with counter display |
| Error Handling | Pass | Friendly messages for invalid input |

## Deployment Devices

Tested on:
- Android phone (Huawei Nova 11, HarmonyOS 4.2.0)
- Android tablet emulator (Pixel C, API 33)

## GitHub Repository

Repository URL: [Your GitHub repository link]

Commit history shows three major submissions demonstrating development progress.

## Screencast Information

- Duration: 10-15 minutes
- Content: All features demonstrated, bug fix explained, all assessment criteria covered
- Platform: MMUTube / Xuexitong