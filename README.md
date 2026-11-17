# Nadeem Mirza — static website starter

A responsive, multi-page static website built with HTML5, CSS3 and vanilla JavaScript. No build tools, backend, ASP.NET or Node.js are required.

## Open in Visual Studio 2026

1. Extract this ZIP to a working folder.
2. Open Visual Studio 2026.
3. Choose **File → Open → Folder...** and select the extracted folder.
4. Open `index.html` in a browser to preview the site.

You can also use a local server from the project folder:

```bash
python -m http.server 5500
```

Then visit http://localhost:5500.

## Pages

- `index.html` — home page
- `about.html` — introduction and background
- `interests.html` — interests and hobbies
- `contact.html` — contact details and email link

## Personalise before publishing

1. Review and edit the text on the About and Interests pages.
2. Replace `REPLACE-WITH-YOUR-EMAIL@example.com` in `contact.html` with your preferred email address (both the `href` and visible text).
3. Optionally add a professional photo to `images/` and replace the portrait placeholder in `about.html`.
4. Update page titles, descriptions and any social/profile links.
5. Check all pages on mobile and desktop.

## Technology

- HTML5
- CSS3 (Flexbox, Grid and media queries)
- Vanilla JavaScript (no jQuery dependency)
- Google Fonts (requires an internet connection; system sans-serif fallback is available)

## Deploy to Cloudflare Pages

This is a static site. Upload the project folder to a Git repository and connect it to Cloudflare Pages, or use the Pages direct-upload workflow.

For a plain static site:
- Build command: leave blank
- Build output directory: `/` (the repository root)
- No framework preset is required

The site has no server-side contact form. The contact link opens the visitor's default email application.
