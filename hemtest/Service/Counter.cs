using hemtest.Model;

namespace hemtest.Service;

public class Counter
{
    private readonly Words _words;

    public Counter()
    {
        _words = new Words();
    }

    // Retrieve list of words from API 
    // Save words to List from user to FrequentWords
    public Task SaveWords(string words)
    {
        //var removeSpaceWords = words.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        _words.FrequentWords.Add(words);

        return Task.CompletedTask;
    }

    // Get FrequentWords List
    // Remove empty strings
    // Write to Frequent list
    public Task SplitWords()
    {
        var allWords = _words.FrequentWords
            .SelectMany(line => line.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            .ToList();

        _words.FrequentWords = allWords;

        return Task.CompletedTask;
    }

    // Get the Frequent List
    // Take 10 most frequent words
    // Count the frequent 10 words
    public Task<Dictionary<string, int>> CalculateFrequentWords()
    {
        var results = _words.FrequentWords
            .GroupBy(words => words)
            .OrderByDescending(cal => cal.Count())
            .Take(10)
            .ToDictionary(cal => cal.Key, cal => cal.Count());

        return Task.FromResult(results);
    }

}

// Source:
// https://stackoverflow.com/questions/9929279/to-count-the-frequency-of-each-word
// https://stackoverflow.com/questions/41548562/how-can-i-count-occurences-of-two-words-following-each-other-in-a-string-in-c/41548832

// FIX README and remind user of: \n if Enter is required.