namespace AtomFeed.Element;

/// <summary>
/// <inheritdoc cref="Person"/>
/// </summary>
public class Author : Person {
    /// <summary>
    /// The initializer of <see cref="Author"/>.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static implicit operator Author(string name) {
        return new Author {
            Name = name
        };
    }

    /// <summary>
    /// Gets an <see cref="Author"/> from a <see cref="Person"/> instance.
    /// </summary>
    /// <param name="person"></param>
    /// <returns></returns>
    public static Author FromPerson(Person person) {
        return new Author {
            Name = person.Name,
            Email = person.Email,
            Uri = person.Uri
        };
    }
}

/// <summary>
/// <inheritdoc cref="Person"/>
/// </summary>
public class Contributor : Person {
    /// <summary>
    /// The initializer of <see cref="Contributor"/>.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static implicit operator Contributor(string name) {
        return new Contributor {
            Name = name
        };
    }

    /// <summary>
    /// Gets a <see cref="Contributor"/> from a <see cref="Person"/> instance.
    /// </summary>
    /// <param name="person"></param>
    /// <returns></returns>
    public static Contributor FromPerson(Person person) {
        return new Contributor {
            Name = person.Name,
            Email = person.Email,
            Uri = person.Uri
        };
    }
}

/// <summary>
/// <c>Author</c> and <c>Contributor</c> describe a person, corporation, or similar entity.
/// </summary>
public class Person {
    /// <summary>
    /// Conveys a human-readable name for the person.
    /// </summary>
    public required string Name { get; set; }

    /// <summary>
    /// Contains an email address for the person.
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Contains a home page for the person.
    /// </summary>
    public string? Uri { get; set; }

    /// <summary>
    /// Gets person name.
    /// </summary>
    /// <returns></returns>
    public override string ToString() {
        return Name;
    }
}