# Food Journal - Food & Drink App

## Second Submission: Image Loading & Enhanced UI

A cross-platform mobile application built with .NET MAUI for tracking food and drink nutrition.

### Features Implemented

#### Core Features
- **Food List Display** - Two-column grid layout with beautiful food cards
- **Real Image Loading** - Load food images from URL (Unsplash, Pexels, etc.)
- **Search Functionality** - Search foods by name, category, description or tags
- **Add New Food** - Complete form with nutrition info and image URL
- **Edit Food** - Modify existing food records
- **Delete Food** - Remove unwanted records with confirmation
- **Food Details** - Detailed view with calories, macros, and allergy info

#### UI/UX Features
- **Dark/Light Theme** - Automatic theme switching with system preference
- **Large Text Mode** - Accessibility feature for better readability
- **Pull to Refresh** - Refresh the food list with gesture
- **Floating Action Button** - Easy access to add new food
- **Gradient Header** - Modern orange gradient design

#### Data Management
- **Local Data Cache** - Works offline with local storage
- **Mock API Ready** - Supports remote API (configurable)
- **CRUD Operations** - Full create, read, update, delete functionality

### Screenshots

| Light Mode | Dark Mode |
|------------|-----------|
| (Add screenshot of main page in light mode) | (Add screenshot of main page in dark mode) |

| Food Details | Add/Edit Form |
|--------------|---------------|
| (Add screenshot of detail page) | (Add screenshot of add/edit form) |

### Technology Stack

- .NET MAUI 8.0
- C# / XAML
- MVVM Pattern
- Local data storage with JSON
- HttpClient for API integration

### How to Run

1. Open `FoodDrinkApp.sln` in Visual Studio 2022
2. Select Android emulator or physical device
3. Press F5 to build and run
4. Grant camera and location permissions when prompted (for hardware features)

### Project Structure
FoodDrinkApp/
├── Models/ # Data models (FoodItem)
├── Services/ # Data services and API client
├── Resources/ # Styles, fonts, images
├── Converters/ # Value converters for XAML binding
├── Platforms/ # Platform-specific code
├── HardwarePage # Camera, location, TTS, vibration demo
├── MainPage # Food list with two-column grid
├── AddItemPage # Add/Edit food form
├── FoodDetailPage # Detailed nutrition view
└── SettingsPage # Theme and accessibility settings


### Hardware Features (Coming in Next Version)

- Camera integration for food photos
- GPS location tracking
- Text-to-speech for nutrition summaries
- Haptic feedback and vibration

### Future Updates

- [x] Two-column grid layout
- [x] Real image loading from URL
- [x] Search functionality
- [x] Complete CRUD operations
- [ ] Camera capture for food photos
- [ ] Location tracking for meals
- [ ] Voice reading of nutrition info

### Known Issues

- Mock API currently using local fallback (network configuration in progress)

---

*Student Project - Mobile Computing Module*