public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Fractions(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public float GetTop()
    {
        return _top;
    }

    public float GetBottom()
    {
        return _bottom;
    }

    public string GetString()
    {
        return $"{GetTop()}/{GetBottom()}";
    }

    public float GetDecimal()
    {
        return GetTop() / GetBottom();
    }
}