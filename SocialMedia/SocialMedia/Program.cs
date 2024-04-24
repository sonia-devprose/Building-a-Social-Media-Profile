using System;

// Represents creating a social media profile with basic functionalities
public class SocialMediaProfile
{

    // Private fields
    private string username;
    private string password;

    // Public properties
    public string DisplayName { get; set; }
    public DateTime DateOfBirth { get; set; }

    // gets or sets whether the profile is active
    internal bool IsActive { get; set; }

    // get or sets the number of friends for the user profile
    protected int FriendCount { get; set; }

    // Constructor
    // Initializes a new instance of SocialMediaProfile class with specified username and password
    public SocialMediaProfile(string username, string password)
    {
        // This line assigns the value of the username argument to the username member variable of the current object (this).
        this.username = username;
        this.password = password;
        this.IsActive = true; // New profiles are active by default

    }

    // Post status
    // <param name="text">The text of the status.</param>
    public void PostStatus(string text)
    {
        Console.WriteLine($"{DisplayName} posted: {text}");

    }

    // <param name="inputPassword">The password to validate.</param>
    private bool ValidatePassword(string inputPassword)
    {

        return inputPassword == password;
    }

    // Protected method

    /// <summary>
    /// Adds a friend to the profile (accessible within derived classes)

    protected void AddFriend()
    {

        FriendCount++;
        Console.WriteLine($"Friend added. {DisplayName} now has {FriendCount} friends.");


    }

}

/// <summary>
/// Represents a premium social media profile with additional features.
/// </summary>
public class PremiumSocialMediaProfile : SocialMediaProfile
{

    public string PremiumFeature { get; set; }
    // Private method to initialize premium features

    public PremiumSocialMediaProfile(string username, string password) : base(username, password)
    {
        InitializePremiumFeatures();

    }

    public void AccessPremiumContent()
    {
        Console.WriteLine($"{DisplayName} is accessing premium content: {PremiumFeature}");

    }
    private void InitializePremiumFeatures()
    {
        PremiumFeature = "Exclusive Premium Content"; // Set premium feature for the profile
    }

}
class Program
{
    public static void Main(string[] args)

    {
        //// Create a new social media profile
        //SocialMediaProfile profile = new SocialMediaProfile("John Doe", "India@2018");

        //// Set profile display name and DOB
        //profile.DisplayName = "John Doe";
        //profile.DateOfBirth = new DateTime(1990, 5, 15);
        //profile.PostStatus("Hello world");
        //profile.AddFriend();
        //Console.WriteLine($"{profile.DisplayName} has a DOB as {profile.DateOfBirth}");

        // Create a new premium social media profile
        PremiumSocialMediaProfile premiumProfile = new PremiumSocialMediaProfile("jane_smith", "secure123");

        // Set profile display name and date of birth
        premiumProfile.DisplayName = "Jane Smith";
        premiumProfile.DateOfBirth = new DateTime(1985, 10, 20);

        // Post a status from premium profile
        premiumProfile.PostStatus("Enjoying the premium features!");

        // Access premium content
        premiumProfile.AccessPremiumContent();

        // Example of accessing profile properties
        Console.WriteLine($"{premiumProfile.DisplayName}'s Date of Birth: {premiumProfile.DateOfBirth}");


    }


}







