namespace AtomFeed.Element;

/// <summary>
/// Specifies a category that the feed or entry belongs to.
/// </summary>
public class Category {
    /// <summary>
    /// Identifies the category.
    /// </summary>
    public required string Term { get; set; }

    /// <summary>
    /// Identifies the categorization scheme via a URI.
    /// </summary>
    public string? Scheme { get; set; }

    /// <summary>
    /// Provides a human-readable label for display.
    /// </summary>
    public string? Label { get; set; }

    /// <summary>
    /// The initializer of <see cref="Category"/>.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static implicit operator Category(string value) {
        return new Category {
            Term = value
        };
    }

    /// <summary>
    /// Gets category term.
    /// </summary>
    /// <returns></returns>
    public override string ToString() {
        return Term;
    }
}