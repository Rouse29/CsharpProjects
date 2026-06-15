// --- FRAUDULENT ORDER CHALLENGE ---
// This array stores the collection of customer Order IDs to review.
string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// We loop through the array to check every single order ID automatically.
foreach (string orderID in orderIDs)
{
    // High-risk pattern detection: Orders starting with "B" encounter fraud at a 25x greater rate.
    if (orderID.StartsWith("B"))
    {
        // Output only the suspicious order IDs to the terminal for the fraud team.
        Console.WriteLine(orderID);
    }
}
