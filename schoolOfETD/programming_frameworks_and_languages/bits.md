Bit's and Bobs - for Assignment 2
=================================

Objectives
----------
* Understand CORS HTTP headers
    * Their purpose and implications for assignment 2
* Consider local environment tooling for development
* Implementation Hints
* Individual Tutorials (10min?)


Hints
-----

### Query String Params

```javascript
	const DEFAULT_API = '/api/v1';  // default to current http(s)://currentHost:currentPort/api/v1'
	const urlParams = new URLSearchParams(window.location.search);
	const urlAPI = (urlParams.get('api') || DEFAULT_API).replace(/\/$/, '');  // Get api url (and remove trailing slash if present)
```

### Data store

A plain dict/associative-array/hashmap/object

```python
ITEMS = {
    1: {
        "id": 1,
        "user_id": "user1234",
        "keywords": ["hammer", "nails", "tools"],
        "description": "A hammer and nails set",
        "lat": 1,
        "lon": 1,
        "date_from": "2021-11-22T08:22:39.067408",
    }
}
NEXT_ID = max(ITEMS.keys()) + 1
```


CORS
----

* [Cross-Origin Resource Sharing (CORS)](https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS)
    * indicate any origins (domain, scheme, or port) other than its own from which a browser should permit loading resources.
    * "preflight" request to the server hosting the cross-origin resource, in order to check that the server will permit the actual request.
    * (client javascript) can only request resources from the same origin the application was loaded from,
        * unless the response from _other origins_ includes the right CORS headers.
* [What is the problem CORS is solving?](https://stackoverflow.com/questions/27365303/what-is-the-issue-cors-is-trying-to-solve)
    * KEY CONCEPT: By default - every time your browser communicates with known domains it WILL provide your authenticated cookie identifiers in HTTP headers.
        * e.g. every time you access `mail.google.com` you send your private access token to allow you to read your inbox
    * > Suppose I accidentally load http://evil.com/, 
        > which sends a request for http://mail.google.com/. 
        > If the SOP were not in place, and I was signed into Gmail, the script at evil.com could see my inbox.
* HTTP Method: [OPTIONS](https://developer.mozilla.org/en-US/docs/Web/HTTP/Methods/OPTIONS) request
    * ```bash
        curl -X OPTIONS http://localhost:8000/ -v
        curl -X OPTIONS http://localhost:8000/items -v
        ```
    * `OPTIONS` Response headers (for pre flight) contain
        * ```
            204
            {
                "Access-Control-Allow-Methods": "POST, GET, OPTIONS, DELETE",
                "Access-Control-Allow-Headers": "Content-Type"
            }
            ```
    * All responses headers (by default) contain
        * ```
            {
                "Access-Control-Allow-Origin": "*"
            }
            ```
    * Hint: In my solution added Middleware to apply all these headers to EVERY response

* Why do browsers all enforce CORS?


Local Development on Windows
----------------------------

All of this is optional - but highly recommended that you understand

### Package management and local (windows) tools
* [chocolatey.org](https://chocolatey.org/)
    * The Package Manager for Windows
    * WindowsKey + X -> Windows Powershell (Admin)
        * copy and paste the big shell line from - [Installing Chocolatey](https://chocolatey.org/install) -> "Now run the following command:"
    * ```powershell
        choco feature enable -n allowGlobalConfirmation
        choco install python3 node
        ```
    * ```cmd
        npm install cypress@8.7.0
            # `npm install` installs to `node_modules` in your current folder!
        set CYPRESS_BASE_URL=http://localhost:8001/?api=http://localhost:8000
            # set an environment variable for the duration of this terminal
        npx cypress open
            # or run headless
        npx cypress run --spec cypress/integration/freecycle/freecycle.spec.js
        ```
        * (I had issues with `9.0.0` on windows, some error about `plugins/index.js`?)

### Docker (on windows)
* Docker on windows
    * [Install WSL](https://docs.microsoft.com/en-us/windows/wsl/install) (Windows Subsystem for Linux)
        * I think it's easier now - you used to have manually turn on HyperV
    * `choco install docker-desktop`
    * [windows-terminal-preview](https://www.microsoft.com/en-gb/p/windows-terminal-preview/9n8g5rfz9xk3#activetab=pivot:overviewtab)

### GUI's from WSL2 and docker containers
* WSL2 and `vcxsrv` (An X11 server) for linux GUI's
    * [Running WSL GUI Apps on Windows 10](https://techcommunity.microsoft.com/t5/windows-dev-appconsult/running-wsl-gui-apps-on-windows-10/ba-p/1493242)
    * Windows
        * ```bash
            choco install vcxsrv
            # start XLaunch -> `Disable access control`
            ```
    * WSL bash
        * ```bash
            echo xfce4-session > ~/.xsession
            export DISPLAY="`grep nameserver /etc/resolv.conf | sed 's/nameserver //'`:0"
            echo $DISPLAY
            sudo apt install gedit
            gedit
            ```
