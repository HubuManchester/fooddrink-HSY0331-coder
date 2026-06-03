namespace FoodDrinkApp.Services;

public static class MockApiConfig
{
    public const string EndpointUrl = "https://6a1ecdaeb79eec0d6cf00c23.mockapi.io/";

    public static bool IsConfigured => !string.IsNullOrWhiteSpace(EndpointUrl);
}
