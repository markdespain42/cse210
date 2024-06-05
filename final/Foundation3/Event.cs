using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _location;

    Lecture lecture = new Lecture();
    Reception reception = new Reception();
    Outdoor outdoor = new Outdoor();

    public string StandardDetails(string _title, string _description, string _date, string _time, string _location) {
        // Lists the title, description, date, time, and address

        return $"Title: {_title}, Description: {_description}, Date: {_date}, Time: {_time}, Location: {_location}";
    }

    public string FullDetails(string _event, string _description, string _date, string _time, string _location) {
        //  Lists all of the above, plus type of event and information specific to that event type.
        // For lectures, this includes the speaker name and capacity. 
        //For receptions this includes an email for RSVP. 
        //For outdoor gatherings, this includes a statement of the weather.
        if (_event == "Lecture") {
            string _speaker = lecture.Speaker("Professor Smith");
            string _capacity = lecture.Capacity(50);
            return $"{_event}, {_description}, {_date}, {_time}, {_location}, Speaker: {_speaker}, Capacity: {_capacity}";
        }
        if (_event == "Reception") {
            string _email = reception.GetEmail("randomemail@example.com");
            reception.AddRsvp("randomemail@example.com");
            if (reception.CheckList("randomemail@example.com") == "Yes") {
                return $"{_event}, {_description}, {_date}, {_time}, {_location}, RSVP: {_email}";
            }
            else {
                return "Sorry, you are not on the list.";
            }
            

        }
        if (_event == "Outdoor") {
            string _weather = outdoor.Weather("Sunny");
            return $"{_event}, {_description}, {_date}, {_time}, {_location}, Weather: {_weather}";
        }
        else {
            return "Sorry, that is not a valid event.";
        }
    }

    public string ShortDescription(string _event, string _date, string _title) {
        //  Lists the title of event, title, and the date

        return $"Event: {_event}, Title: {_title}, Date: {_date}";
    }
}
