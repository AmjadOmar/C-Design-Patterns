public class EngineProxy : IEngine
{
    private IEngine engine;

    public EngineProxy(int size, bool turbo)
    {
        if (turbo)
        {
            engine = new TurboEngine(size);
        }
        else
        {
            engine = new StandardEngine(size);
        }
    }

    public virtual int Size
    {
        get
        {
            return engine.Size;
        }
    }

    public virtual bool Turbo
    {
        get
        {
            return engine.Turbo;
        }
    }
}