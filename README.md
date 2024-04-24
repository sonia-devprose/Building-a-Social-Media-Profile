## Title: Building a Social Media Profile with Inheritance in C#

## Description:

This code demonstrates creating social media profiles with basic functionalities in C#. It utilizes concepts like classes, inheritance, and access modifiers to achieve encapsulation and code reusability.

The code defines two classes:

  - **SocialMediaProfile:** This base class represents a standard social media profile with functionalities like setting a display name, date of birth, posting a status, and adding friends (protected method). It also has properties with different access modifiers (`public`, `internal`, `protected`) showcasing their usage.

  - **PremiumSocialMediaProfile:** This class inherits from `SocialMediaProfile` and represents a premium profile with additional features like accessing premium content and a specific premium feature property. It demonstrates the concept of inheritance where the derived class inherits properties and methods from the base class and can add its own functionalities.

The `Main` function showcases creating both standard and premium profiles, setting their properties, posting statuses, accessing premium features (for premium profiles), and demonstrating how access modifiers restrict access to certain properties and methods.


