namespace TW.Teddysoft.src.Observer.exercise
{
    public interface ISubject
    {
        void addObserver(IObserver observer);
        void deleteObserver(IObserver observer);
        void notifyObserver();
    }
}