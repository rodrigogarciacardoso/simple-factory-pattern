# Simple Factory Pattern

This project is a demonstration of the *Simple Factory Design Pattern*. The goal is to illustrate how we can centralize object creation logic, decoupling the client from the concrete classes it needs to instantiate.

To exemplify this, a single-endpoint API was developed to create and use different types of notifiers (e.g., Email, SMS).

## What is the Simple Factory Pattern?

The Simple Factory is not one of the original 23 "Gang of Four" (GoF) patterns, but it is an extremely common and useful programming technique. It consists of a class, the "factory," which has a method responsible for creating objects of different types, usually based on an input parameter.

This removes the instantiation logic (`new ConcreteClass()`) from the client code, centralizing it in a single point. The client now depends only on the factory and the common interface of the objects, without needing to know all the concrete implementations.

### Key Advantages

* **Centralization:** The creation logic is in one place, making maintenance easier.
* **Decoupling:** The client does not know the concrete classes. If a new class is added, the client code does not need to be changed.
* **Flexibility:** It is easy to switch implementations or add new ones.

## Practical Example: Notifier Factory

In this project, the client needs to send notifications but should not be concerned with how to construct an Email, SMS, or Push notifier.

The `NotificationFactory` is responsible for this. The client simply requests a type of notifier from the factory (e.g., "EMAIL"), and the factory returns the object ready to be used.

## Project Structure

* **Controller:** Receives HTTP requests to send a notification.
* **Service:** Contains the business logic and uses the Factory to get the correct notifier.
* **Product:**
    * `NotificationType` (Interface): Defines the contract that all notifiers must follow (e.g., a `send()` method).
    * `EmailNotification`, `SmsNotification` (Concrete Classes): Specific implementations for each notification type.
* **Factory:**
    * `NotificationFactory`: The class that contains the static method for creating `Notification` objects.
