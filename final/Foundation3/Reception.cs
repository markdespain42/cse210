using System;

public class Reception : Event {

    private string _email;

    private List<string> _rsvpList = new List<string>();

    public string GetEmail(string email) {
        _email = email;

        return _email;
    }
    public void AddRsvp(string email) {
        _rsvpList.Add(email);
    }
    public string CheckList(string email) {
        if (_rsvpList.Contains(email)) {
            return "Yes";
        } else {
            return "No";
        }
    }
}