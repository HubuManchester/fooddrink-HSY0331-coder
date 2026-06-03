# Food Journal App

## Second Submission - Image Loading Version

### What's New in This Submission

- Real Image Loading - Food cards now display actual images from URLs
- Search Feature - Search foods by name, category, or description
- Two-Column Grid - Modern layout inspired by food delivery apps
- Orange Theme - New gradient header and color scheme
- Category Icons - Fallback icons when images are not available

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
| Mock API Integration | Configured (local fallback) |
| Hardware Features | Next Version |

### Image URL Examples

You can use these free image URLs for testing:

| Food Type | Example Source |
|-----------|----------------|
| Breakfast | Unsplash / Pexels food photos |
| Lunch | Unsplash / Pexels food photos |
| Drink | Unsplash / Pexels food photos |

### How to Add Images

1. Go to Add Item page
2. Find a food image online (Unsplash, Pexels, etc.)
3. Right-click the image and select "Copy Image Address"
4. Paste into the Image URL field
5. Save - the image will appear on the food card

### Testing Checklist

- [ ] Main page shows two-column grid
- [ ] Search bar filters results correctly
- [ ] Add new food with image URL works
- [ ] Edit existing food works
- [ ] Delete food with confirmation works
- [ ] Dark mode looks correct
- [ ] Light mode looks correct
- [ ] Large text mode scales properly

### Build Instructions
dotnet clean
dotnet restore
dotnet build

dotnet build -f net8.0-android


### Troubleshooting

Images not showing?
- Make sure the URL ends with .jpg, .png, or is a valid image direct link
- Check internet connection

Search not working?
- Make sure you are typing a word that exists in name, category, or description

App crashes?
- Try cleaning and rebuilding the solution
- Delete bin and obj folders, then rebuild

### Next Version Plans

- Hardware page with camera, location, TTS, vibration
- Real-time location tracking for meals
- Voice reading of nutrition summaries
- Photo capture instead of URL

---

For more details, see the main README in the project root.