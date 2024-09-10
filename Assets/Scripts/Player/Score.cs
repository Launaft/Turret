public static class Score
{
    public static int ScorePoints { get { return _score; } }

    private static int _score = 0;

    public static void Increase(int points) => _score += points;

    public static void Decrease(int points) => _score -= points;

    public static void ResetScore() => _score = 0;
}