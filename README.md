# JsonBreaker
JsonBreaker is a console app that breaks static JSON files to smaller sets to enable lazy loading of JSON data.

## Abstract
Static websites often required pre-defined data specified on JSON files. Loading huge static JSON files means slower load time of a website. For online business, this could cost them potential customers and sales. To solve this problem, we need to find a way to break the size based problem originating from this huge JSON files by splitting it to smaller pieces. 

## Why would we need smaller JSON data sets?
Smaller static JSON files enables loading of data in a paginated fashion. To elaborate this further, consider that you have a JSON file that contains 1000+ items inside. To load your initial interface, you'll not probably gonna need all of those. Most of the time you'll just need 5-10 items to show in your initial load time and the breaking the huge JSON file to smaller pieces would help greatly to this issue.

## Benefits
- Efficient initial load time
- Smaller HTTP request
- Smaller outbound traffic cost if your hosting your site on cloud-based providers.
- Faster multi-region response time since latency will never be an issue (Latency is the time required for a certain packet of communication to travel across a given distance) since it only requires one round trip for communication to complete (The huge JSON file, would not fit on a typical transmission unit).

## Notes

I hope this tool will help alot of people out there and please do feel free to contribute to this repository, I'll gladly review your changes and accept them.

### Cheers!
