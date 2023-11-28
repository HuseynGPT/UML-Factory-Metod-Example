abstract class Dialog
{
    public void render()
    {
        IButton okButton = createButton();
        okButton.onClick();
        okButton.render();
    }

    public virtual IButton createButton()
    {
        return null;
    }

}

interface IButton
{
    void render();
    void onClick();

}


class WindowsDialog:Dialog
{
    public override IButton createButton()
    {
        return new WindowsButton();
    }
}

class WebDialog : Dialog
{
    public override IButton createButton()
    {
        return new WindowsButton();
    }
}

class WindowsButton : IButton
{
    public void onClick()
    {

        // code
    }

    public void render()
    {
        throw new NotImplementedException();
    }
}

class HTMLButton : IButton
{
    public void onClick()
    {
        throw new NotImplementedException();
    }

    public void render()
    {
        throw new NotImplementedException();
    }
}