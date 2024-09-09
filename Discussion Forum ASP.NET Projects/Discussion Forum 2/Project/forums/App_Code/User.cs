using System;

public class User
{
    private string id,email, fullname, occup;
	public User()
	{
	}
    public User(string id, string email, string fullname, string occup)
    {
        this.id = id;
        this.email = email;
        this.fullname = fullname;
        this.occup = occup;
    }

    public string Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }

    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            email = value;
        }
    }

    public string FullName
    {
        get
        {
            return fullname;
        }
        set
        {
            fullname = value;
        }
    }

    public string Occupation
    {
        get
        {
            return occup;
        }
        set
        {
            occup = value;
        }
    }

}
