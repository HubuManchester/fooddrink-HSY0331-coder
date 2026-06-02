using FoodDrinkApp.Services;

namespace FoodDrinkApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        AccessibilityService.ApplyFontScale(this);
        await LoadFoodItemsAsync();
    }

    private async Task LoadFoodItemsAsync()
    {
        FoodCollection.ItemsSource = await FoodCatalogService.SearchAsync(null);
    }

    private async void OnAddClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddItemPage));
    }

    private async void OnDetailsClicked(object? sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is string id)
        {
            await Shell.Current.GoToAsync($"{nameof(FoodDetailPage)}?id={Uri.EscapeDataString(id)}");
        }
    }

    private async void OnRefreshing(object? sender, EventArgs e)
    {
        await LoadFoodItemsAsync();
        FoodRefreshView.IsRefreshing = false;
        var source = FoodCatalogService.LastLoadUsedMockApi ? "Mock API" : "Local data";
        SemanticScreenReader.Announce($"Food list refreshed. Source: {source}.");
    }
}