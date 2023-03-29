Feature: Time API
    In order to get the current time
    As a user of the API
    I want to be able to make a GET request to a time endpoint

Scenario: Get current time
    Given the time API endpoint is "/api/time"
    When I make a GET request to the endpoint
    Then the response status code should be 200
    And the response body should contain the current time in ISO format
